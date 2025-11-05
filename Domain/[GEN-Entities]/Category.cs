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
    
    /// <summary>Represents an instance of Category entity type.</summary>
    [EscapeGCop("Auto generated code.")]
    public partial class Category : GuidEntity
    {
        /// <summary>Initializes a new instance of the Category class.</summary>
        public Category() => Deleting += (ev) => ev.Do(Cascade_Deleting);
        
        /// <summary>Gets or sets the value of Name on this Category instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Name { get; set; }
        
        /// <summary>Returns a textual representation of this Category.</summary>
        public override string ToString() => Name;
        
        /// <summary>Returns a clone of this Category.</summary>
        /// <returns>
        /// A new Category object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new Category Clone() => (Category)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Category and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Name.IsEmpty())
                result.Add("Name cannot be empty.");
            
            if (Name?.Length > 200)
                result.Add("The provided Name is too long. A maximum of 200 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Throws a validation exception if any record depends on this Category which cannot be cascade-deleted.<para/>
        /// </summary>
        public virtual async Task ValidateCanBeDeleted()
        {
            var dependantContacts = await Database.Count<Contact>(c => c.CategoryId == ID);
            
            if (dependantContacts > 0)
            {
                throw new ValidationException("This Category cannot be deleted because of {0} dependent Contact record(s).", dependantContacts);
            }
        }
        
        /// <summary>Handles the Deleting event of this Category.</summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="e">The CancelEventArgs instance containing the event data.</param>
        async Task Cascade_Deleting()
        {
            await ValidateCanBeDeleted();
        }
    }
}