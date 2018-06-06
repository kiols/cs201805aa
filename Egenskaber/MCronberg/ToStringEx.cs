namespace MCronberg
{
    using System.Linq;
    public static class MCronbergExtensions
    {

        public static string ToStringEx(this object obj, bool showFields = true, bool showProperties = true, bool showMethods = true)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string types = "(";
            if (showFields)
                types += "fields ";
            if (showProperties)
                types += "properties ";
            if (showMethods)
                types += "methods ";

            types = types.Trim().Replace(" ", ",") + ")";
            if (types.Split(',').Length == 1)
                types = types.Replace(")", " only)");

            if (types.Split(',').Length == 2)
                types = types.Replace(",", " and ");
            else
                types = types.Replace(",", ", ");

            string header = "Showing members " + types + " from object of type " + obj.GetType().ToString() + ":";
            sb.AppendLine(header);
            sb.Append(new string('-', header.Length));
            sb.AppendLine("");
            if (showFields)
            {

                sb.AppendLine("Fields:");
                sb.AppendLine("");
                foreach (var item in obj.GetType().GetFields(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.DeclaredOnly).OrderBy(i => i.Name))
                {
                    string a = "Private ";
                    if (item.IsPublic)
                        a = "Public ";
                    object value = item.GetValue(obj);

                    if (value == null)
                        value = "null";
                    sb.AppendLine(print(a, 10) + " " + print(item.FieldType.ToString(), 25) + " " + print(item.Name, 30) + " " + print(value.ToString(), 20));
                }
                sb.AppendLine("");
            }
            if (showProperties)
            {
                sb.AppendLine("Properties:");
                sb.AppendLine("");
                foreach (var item in obj.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.DeclaredOnly).OrderBy(i => i.Name))
                {
                    string a = "";
                    if (item.CanRead && item.CanWrite)
                        a = "get/set";
                    if (item.CanRead && !item.CanWrite)
                        a = "get";
                    if (!item.CanRead && item.CanWrite)
                        a = "set";

                    object value = item.GetValue(obj);
                    if (value == null)
                        value = "null";
                    sb.AppendLine("" + print(a, 10) + " " + print(item.PropertyType.ToString(), 25) + " " + print(item.Name, 30) + " " + print(value.ToString(), 20) + "");
                }
                sb.AppendLine("");
            }
            if (showMethods)
            {

                sb.AppendLine("Methods:");
                sb.AppendLine("");
                foreach (var item in obj.GetType().GetMethods(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.DeclaredOnly).OrderBy(i => i.Name))
                {
                    string a = "Private ";
                    if (item.IsPublic)
                        a = "Public ";
                    object value = "";
                    if (value == null)
                        value = "null";
                    sb.AppendLine("" + print(a, 10) + " " + print(item.ReturnType.ToString(), 25) + " " + print(item.Name, 30) + " " + print(value.ToString(), 20));

                }
                sb.AppendLine("");

                sb.AppendLine("More info:");
                sb.AppendLine("");
                sb.AppendLine(print("Primitive", 37) + print(obj.GetType().IsPrimitive.ToString(), 30));
                sb.AppendLine(print("ValueType", 37) + print(obj.GetType().IsValueType.ToString(), 30));
                sb.AppendLine(print("ReferenceType", 37) + print(obj.GetType().IsClass.ToString(), 30));
                sb.AppendLine(print("Array", 37) + print(obj.GetType().IsArray.ToString(), 30));
                sb.AppendLine(print("Abstract", 37) + print(obj.GetType().IsAbstract.ToString(), 30));
                sb.AppendLine(print("Enum", 37) + print(obj.GetType().IsEnum.ToString(), 30));
                if (obj.GetType().IsEnum)
                    sb.AppendLine(print("Enum value", 37) + print(obj.ToString(), 30));
                sb.AppendLine(print("Interface", 37) + print(obj.GetType().IsInterface.ToString(), 30));
                sb.AppendLine(print("Sealed", 37) + print(obj.GetType().IsSealed.ToString(), 30));



            }
            string print(string txt, int length)
            {
                if (txt.Length > length)
                {
                    txt = txt.Substring(0, length - 2) + "..";
                }
                return txt.PadRight(length);
            }



            return sb.ToString();
        }

    }
}