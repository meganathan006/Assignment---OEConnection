import { useRouteError } from "react-router-dom";
import Navbar from "../Layout/Navbar/Navbar";

export default function ErrorPage() {
    const error = useRouteError();
    console.error(error);

    return (
        <>
            <Navbar />
            <div className="container align-items-center container d-flex justify-content-center vh-100">
                <div>
                    <h1>Oops!</h1>
                    <p>Sorry, an unexpected error has occurred.</p>
                    <p>
                        <i>{error.statusText || error.message}</i>
                    </p>
                </div>
            </div>
        </>
    );
}
