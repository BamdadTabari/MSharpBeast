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
    
    /// <summary>Represents an instance of Blog entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class Blog : GuidEntity
    {
        /// <summary>Initializes a new instance of the Blog class.</summary>
        public Blog() => ViewCount = 0;
        
        /// <summary>Gets or sets the value of BlogContent on this Blog instance.</summary>
        public string BlogContent { get; set; }
        
        /// <summary>Gets or sets the value of BlogTitle on this Blog instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string BlogTitle { get; set; }
        
        /// <summary>Gets or sets the value of ViewCount on this Blog instance.</summary>
        public int? ViewCount { get; set; }
        
        /// <summary>Returns a textual representation of this Blog.</summary>
        public override string ToString() => BlogTitle;
        
        /// <summary>Returns a clone of this Blog.</summary>
        /// <returns>
        /// A new Blog object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Blog Clone() => (Blog)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Blog and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (BlogContent.IsEmpty())
                result.Add("Blog content cannot be empty.");
            
            if (BlogTitle.IsEmpty())
                result.Add("Blog title cannot be empty.");
            
            if (BlogTitle?.Length > 200)
                result.Add("The provided Blog title is too long. A maximum of 200 characters is acceptable.");
            
            if (ViewCount < 0)
                result.Add("The value of View count must be 0 or more.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
    }
}