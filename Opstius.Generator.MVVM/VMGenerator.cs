using Opstius.Generator.MVVM.Models;
using System.Text;

namespace Opstius.Generator.MVVM
{
    public static class VMGenerator
    {
        public static string Generate(VMClass model)
        {
            return GenerateClass(model);
        }
        private static string GenerateClass(VMClass model)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"public sealed class {model.ViewModelName} : BaseVM");
            builder.AppendLine($"{{");

            foreach (VMProperty property in model.Properties)
            {
                builder.Append(GenerateVariable(property));
            }
            builder.AppendLine();

            foreach (VMProperty property in model.Properties)
            {
                builder.Append(GenerateProperty(property));
            }

            builder.AppendLine($"}}");

            return builder.ToString();
        }
        private static string GenerateVariable(VMProperty model)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"private {model.Type} {model.VariableName};");

            return builder.ToString();
        }
        private static string GenerateProperty(VMProperty model)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"public {model.Type} {model.Name}");
            builder.AppendLine($"{{");
            builder.AppendLine($"set");
            builder.AppendLine($"{{");
            builder.AppendLine($"if ({model.VariableName} != value)");
            builder.AppendLine($"{{");
            builder.AppendLine($"{model.VariableName} = value;");
            builder.AppendLine($"OnPropertyChanged(\"{model.Name}\");");
            builder.AppendLine($"}}");
            builder.AppendLine($"}}");
            builder.AppendLine($"get");
            builder.AppendLine($"{{");
            builder.AppendLine($"return {model.VariableName};");
            builder.AppendLine($"}}");
            builder.AppendLine($"}}");

            return builder.ToString();
        }
    }
}
