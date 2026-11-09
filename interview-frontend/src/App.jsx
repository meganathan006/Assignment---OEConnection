import { useNavigate } from "react-router-dom";
import { startPlan } from "./api/api";
import Layout from "./components/Layout/Layout";

const App = () => {
    var navigate = useNavigate();

    const start = async () => {
        var plan = await startPlan();
        navigate(`/plan/${plan.planId}`);
    };

    return (
        <Layout>
            <div className="container">
                <div className="text-center mt-4">
                    <h3>Start Here</h3>
                    <p>Click "start" to begin</p>
                    <button className="btn btn-primary" onClick={() => start()}>
                        Start
                    </button>
                </div>
            </div>
        </Layout>
    );
};

export default App;
