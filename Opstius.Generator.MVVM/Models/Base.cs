namespace Opstius.Generator.MVVM.Models
{
    public abstract class BaseClass
    {
        public string Name { set; get; } = string.Empty;
        public List<BaseProperty> Properties { set; get; } = new List<BaseProperty>();
        public string DataModelName => Name + "DM";
        public string ViewModelName => Name + "VM";
    }
    public abstract class BaseProperty
    {
        public string Type { set; get; } = string.Empty;
        public string Name { set; get; } = string.Empty;
        public string Value { set; get; } = string.Empty;
        public string VariableName => "_" + Name;
    }
}
