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
    
    /// <summary>Represents an instance of Contact entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class Contact : GuidEntity
    {
        CachedReference<Category> cachedCategory = new CachedReference<Category>();
        
        /// <summary>Gets or sets the value of Email on this Contact instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Email { get; set; }
        
        /// <summary>Gets or sets the value of FirstName on this Contact instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string FirstName { get; set; }
        
        /// <summary>Gets or sets the value of LastName on this Contact instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string LastName { get; set; }
        
        /// <summary>Gets the Name property.</summary>
        [Calculated]
        public string Name
        {
            get => FirstName + " " + LastName;
        }
        
        /// <summary>Gets or sets the value of PhoneNumber on this Contact instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string PhoneNumber { get; set; }
        
        /// <summary>Gets or sets the ID of the associated Category.</summary>
        public Guid? CategoryId { get; set; }
        
        /// <summary>Gets or sets the value of Category on this Contact instance.</summary>
        public Category Category
        {
            get => cachedCategory.Get(CategoryId);
            set => CategoryId = value?.ID;
        }
        
        /// <summary>Returns a textual representation of this Contact.</summary>
        public override string ToString() => FirstName;
        
        /// <summary>Returns a clone of this Contact.</summary>
        /// <returns>
        /// A new Contact object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Contact Clone() => (Contact)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Contact and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (CategoryId == null)
                result.Add("Please provide a value for Category.");
            
            if (Email?.Length > 200)
                result.Add("The provided Email is too long. A maximum of 200 characters is acceptable.");
            
            // Ensure Email matches Email address pattern:
            
            if (Email.HasValue() && !System.Text.RegularExpressions.Regex.IsMatch(Email, "\\s*\\w+([-+.'\\w])*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*\\s*"))
                result.Add("The provided Email is not a valid Email address.");
            
            if (FirstName.IsEmpty())
                result.Add("First name cannot be empty.");
            
            if (FirstName?.Length > 200)
                result.Add("The provided First name is too long. A maximum of 200 characters is acceptable.");
            
            if (LastName.IsEmpty())
                result.Add("Last name cannot be empty.");
            
            if (LastName?.Length > 200)
                result.Add("The provided Last name is too long. A maximum of 200 characters is acceptable.");
            
            if (PhoneNumber.IsEmpty())
                result.Add("Phone number cannot be empty.");
            
            if (PhoneNumber?.Length > 200)
                result.Add("The provided Phone number is too long. A maximum of 200 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
    }
}