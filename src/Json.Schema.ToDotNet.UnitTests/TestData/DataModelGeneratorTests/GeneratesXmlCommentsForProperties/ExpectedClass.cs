using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace N
{
    [DataContract]
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "$JSchemaFileVersion$")]
    public partial class C
    {
        /// <summary>
        /// An example property.
        /// </summary>
        [DataMember(Name = "exampleProp", IsRequired = false, EmitDefaultValue = false)]
        public string ExampleProp { get; set; }
    }
}