namespace Opstius.Generator.MVVM.Models
{
    public sealed class VMClass : BaseClass
    {
        public bool HasDM { set; get; } = false;
    }
    public sealed class VMProperty : BaseProperty
    {
        public bool HasDM { set; get; } = false;
    }
}
