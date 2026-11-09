namespace RL.Data.DataModels.Common;

public interface IChangeTrackable
{
    DateTime CreateDate { get; set; }
    DateTime UpdateDate { get; set; }
}