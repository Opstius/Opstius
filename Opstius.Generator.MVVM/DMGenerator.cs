using Opstius.Generator.MVVM.Models;
using System.Text;

namespace Opstius.Generator.MVVM
{
    public static class DMGenerator
    {
        public static string Generate(DMClass model)
        {
            return GenerateClass(model);
        }
        private static string GenerateClass(DMClass model)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"[XmlRoot(\"{model.Name}\")]");
            builder.AppendLine($"public sealed class {model.DataModelName}");
            builder.AppendLine($"{{");

            foreach (DMProperty property in model.Properties)
            {
                builder.AppendLine(GenerateProperty(property));
            }

            builder.AppendLine($"}}");

            return builder.ToString();
        }
        private static string GenerateProperty(DMProperty model)
        {
            StringBuilder builder = new StringBuilder();

            string value = Utilities.GetDMValue(model.Type, model.Value);

            builder.AppendLine($"[XmlElement(\"{model.Name}\")]");
            builder.AppendLine($"[JsonPropertyName(\"{model.Name}\")]");
            builder.AppendLine($"public {model.Type} {model.Name} {{ set; get; }} = {value};");

            return builder.ToString();
        }
    }
}
