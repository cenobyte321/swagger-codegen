/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// FormatTest
    /// </summary>
    [DataContract]
        public partial class FormatTest :  IEquatable<FormatTest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTest" /> class.
        /// </summary>
        /// <param name="integer">integer.</param>
        /// <param name="int32">int32.</param>
        /// <param name="int64">int64.</param>
        /// <param name="number">number (required).</param>
        /// <param name="_float">_float.</param>
        /// <param name="_double">_double.</param>
        /// <param name="_string">_string.</param>
        /// <param name="_byte">_byte (required).</param>
        /// <param name="binary">binary.</param>
        /// <param name="date">date (required).</param>
        /// <param name="dateTime">dateTime.</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="password">password (required).</param>
        public FormatTest(int? integer = default(int?), int? int32 = default(int?), long? int64 = default(long?), decimal? number = default(decimal?), float? _float = default(float?), double? _double = default(double?), string _string = default(string), byte[] _byte = default(byte[]), byte[] binary = default(byte[]), DateTime? date = default(DateTime?), DateTime? dateTime = default(DateTime?), Guid? uuid = default(Guid?), string password = default(string))
        {
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new InvalidDataException("number is a required property for FormatTest and cannot be null");
            }
            else
            {
                this.Number = number;
            }
            // to ensure "_byte" is required (not null)
            if (_byte == null)
            {
                throw new InvalidDataException("_byte is a required property for FormatTest and cannot be null");
            }
            else
            {
                this.Byte = _byte;
            }
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for FormatTest and cannot be null");
            }
            else
            {
                this.Date = date;
            }
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for FormatTest and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            this.Integer = integer;
            this.Int32 = int32;
            this.Int64 = int64;
            this.Float = _float;
            this.Double = _double;
            this.String = _string;
            this.Binary = binary;
            this.DateTime = dateTime;
            this.Uuid = uuid;
        }
        
        /// <summary>
        /// Gets or Sets Integer
        /// </summary>
        [DataMember(Name="integer", EmitDefaultValue=false)]
        public int? Integer { get; set; }

        /// <summary>
        /// Gets or Sets Int32
        /// </summary>
        [DataMember(Name="int32", EmitDefaultValue=false)]
        public int? Int32 { get; set; }

        /// <summary>
        /// Gets or Sets Int64
        /// </summary>
        [DataMember(Name="int64", EmitDefaultValue=false)]
        public long? Int64 { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public decimal? Number { get; set; }

        /// <summary>
        /// Gets or Sets Float
        /// </summary>
        [DataMember(Name="float", EmitDefaultValue=false)]
        public float? Float { get; set; }

        /// <summary>
        /// Gets or Sets Double
        /// </summary>
        [DataMember(Name="double", EmitDefaultValue=false)]
        public double? Double { get; set; }

        /// <summary>
        /// Gets or Sets String
        /// </summary>
        [DataMember(Name="string", EmitDefaultValue=false)]
        public string String { get; set; }

        /// <summary>
        /// Gets or Sets Byte
        /// </summary>
        [DataMember(Name="byte", EmitDefaultValue=false)]
        public byte[] Byte { get; set; }

        /// <summary>
        /// Gets or Sets Binary
        /// </summary>
        [DataMember(Name="binary", EmitDefaultValue=false)]
        public byte[] Binary { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name="dateTime", EmitDefaultValue=false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid? Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormatTest {\n");
            sb.Append("  Integer: ").Append(Integer).Append("\n");
            sb.Append("  Int32: ").Append(Int32).Append("\n");
            sb.Append("  Int64: ").Append(Int64).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Float: ").Append(Float).Append("\n");
            sb.Append("  Double: ").Append(Double).Append("\n");
            sb.Append("  String: ").Append(String).Append("\n");
            sb.Append("  Byte: ").Append(Byte).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FormatTest);
        }

        /// <summary>
        /// Returns true if FormatTest instances are equal
        /// </summary>
        /// <param name="input">Instance of FormatTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormatTest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Integer == input.Integer ||
                    (this.Integer != null &&
                    this.Integer.Equals(input.Integer))
                ) && 
                (
                    this.Int32 == input.Int32 ||
                    (this.Int32 != null &&
                    this.Int32.Equals(input.Int32))
                ) && 
                (
                    this.Int64 == input.Int64 ||
                    (this.Int64 != null &&
                    this.Int64.Equals(input.Int64))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Float == input.Float ||
                    (this.Float != null &&
                    this.Float.Equals(input.Float))
                ) && 
                (
                    this.Double == input.Double ||
                    (this.Double != null &&
                    this.Double.Equals(input.Double))
                ) && 
                (
                    this.String == input.String ||
                    (this.String != null &&
                    this.String.Equals(input.String))
                ) && 
                (
                    this.Byte == input.Byte ||
                    (this.Byte != null &&
                    this.Byte.Equals(input.Byte))
                ) && 
                (
                    this.Binary == input.Binary ||
                    (this.Binary != null &&
                    this.Binary.Equals(input.Binary))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Integer != null)
                    hashCode = hashCode * 59 + this.Integer.GetHashCode();
                if (this.Int32 != null)
                    hashCode = hashCode * 59 + this.Int32.GetHashCode();
                if (this.Int64 != null)
                    hashCode = hashCode * 59 + this.Int64.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Float != null)
                    hashCode = hashCode * 59 + this.Float.GetHashCode();
                if (this.Double != null)
                    hashCode = hashCode * 59 + this.Double.GetHashCode();
                if (this.String != null)
                    hashCode = hashCode * 59 + this.String.GetHashCode();
                if (this.Byte != null)
                    hashCode = hashCode * 59 + this.Byte.GetHashCode();
                if (this.Binary != null)
                    hashCode = hashCode * 59 + this.Binary.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.DateTime != null)
                    hashCode = hashCode * 59 + this.DateTime.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }
    }
}
