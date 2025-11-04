namespace Domain
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Xml.Serialization;
    using Olive;
    using Olive.Entities;
    using Olive.Entities.Data;
    
    /// <summary>Represents an instance of Logon failure entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class LogonFailure : GuidEntity
    {
        /// <summary>Gets or sets the value of Attempts on this Logon failure instance.</summary>
        public int Attempts { get; set; }
        
        /// <summary>Gets or sets the value of Date on this Logon failure instance.</summary>
        public DateTime Date { get; set; }
        
        /// <summary>Gets or sets the value of Email on this Logon failure instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Email { get; set; }
        
        /// <summary>Gets or sets the value of IP on this Logon failure instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string IP { get; set; }
        
        /// <summary>Returns a textual representation of this Logon failure.</summary>
        public override string ToString() => Email;
        
        /// <summary>Returns a clone of this Logon failure.</summary>
        /// <returns>
        /// A new Logon failure object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new LogonFailure Clone() => (LogonFailure)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Logon failure and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Attempts < 0)
                result.Add("The value of Attempts must be 0 or more.");
            
            if (Email.IsEmpty())
                result.Add("Email cannot be empty.");
            
            if (Email?.Length > 200)
                result.Add("The provided Email is too long. A maximum of 200 characters is acceptable.");
            
            if (IP.IsEmpty())
                result.Add("IP cannot be empty.");
            
            if (IP?.Length > 200)
                result.Add("The provided IP is too long. A maximum of 200 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
    }
}