using System.ComponentModel;

namespace Taskio.Domain.Enumerables
{
    public enum Status
    {
        [Description("To Do")]
        ToDo = 0,
        [Description("Doing")]
        Doing = 1,
        [Description("Done")]
        Done = 2,
        [Description("Canceled")]
        Canceled = 3
    }
}
