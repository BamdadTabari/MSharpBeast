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
    
    /// <summary>Represents an instance of Administrator entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class Administrator : User
    {
        /// <summary>Gets or sets the value of ImpersonationToken on this Administrator instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public string ImpersonationToken { get; set; }
        
        /// <summary>Returns a clone of this Administrator.</summary>
        /// <returns>
        /// A new Administrator object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Administrator Clone() => (Administrator)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Administrator and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override async Task ValidateProperties()
        {
            var result = new List<string>();
            
            try
            {
                await base.ValidateProperties();
            }
            catch (ValidationException ex)
            {
                result.Add(ex.Message);
            }
            
            if (ImpersonationToken?.Length > 40)
                result.Add("The provided Impersonation token is too long. A maximum of 40 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
        }
    }
}