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
    
    /// <summary>Represents an instance of Audit event entity type.</summary>
    [CacheObjects(false)]
    [EscapeGCop("Auto generated code.")]
    public partial class AuditEvent : GuidEntity, Olive.Audit.IAuditEvent
    {
        /// <summary>Initializes a new instance of the AuditEvent class.</summary>
        public AuditEvent() => Date = LocalTime.Now;
        
        /// <summary>Gets or sets the value of Date on this Audit event instance.</summary>
        public DateTime Date { get; set; }
        
        /// <summary>Gets or sets the value of Event on this Audit event instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string Event { get; set; }
        
        /// <summary>Gets or sets the value of ItemData on this Audit event instance.</summary>
        public string ItemData { get; set; }
        
        /// <summary>Gets or sets the value of ItemGroup on this Audit event instance.</summary>
        public string ItemGroup { get; set; }
        
        /// <summary>Gets or sets the value of ItemId on this Audit event instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string ItemId { get; set; }
        
        /// <summary>Gets or sets the value of ItemType on this Audit event instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string ItemType { get; set; }
        
        /// <summary>Gets or sets the value of UserId on this Audit event instance.</summary>
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string UserId { get; set; }
        
        /// <summary>Gets or sets the value of UserIp on this Audit event instance.</summary>
        [System.ComponentModel.DisplayName("User Ip")]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string UserIp { get; set; }
        
        /// <summary>Returns a textual representation of this Audit event.</summary>
        public override string ToString() => Event;
        
        /// <summary>Returns a clone of this Audit event.</summary>
        /// <returns>
        /// A new Audit event object with the same ID of this instance and identical property values.<para/>
        ///  The difference is that this instance will be unlocked, and thus can be used for updating in database.<para/>
        /// </returns>
        public new AuditEvent Clone() => (AuditEvent)base.Clone();
        
        /// <summary>
        /// Validates the data for the properties of this Audit event and throws a ValidationException if an error is detected.<para/>
        /// </summary>
        protected override Task ValidateProperties()
        {
            var result = new List<string>();
            
            if (Event.IsEmpty())
                result.Add("Event cannot be empty.");
            
            if (Event?.Length > 200)
                result.Add("The provided Event is too long. A maximum of 200 characters is acceptable.");
            
            if (ItemId?.Length > 500)
                result.Add("The provided Item id is too long. A maximum of 500 characters is acceptable.");
            
            if (ItemType?.Length > 200)
                result.Add("The provided Item type is too long. A maximum of 200 characters is acceptable.");
            
            if (UserId?.Length > 200)
                result.Add("The provided User id is too long. A maximum of 200 characters is acceptable.");
            
            if (UserIp?.Length > 200)
                result.Add("The provided User Ip is too long. A maximum of 200 characters is acceptable.");
            
            if (result.Any())
                throw new ValidationException(result.ToLinesString());
            
            return Task.CompletedTask;
        }
    }
}