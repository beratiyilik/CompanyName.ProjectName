using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CompanyName.ProjectName.Common.Framework.Entity.Interface;
using static CompanyName.ProjectName.Common.Framework.Enum.Enum;

namespace CompanyName.ProjectName.Common.Framework.Entity
{
    public abstract class BaseEntity<TKey> : IEntity<TKey> where TKey : struct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual TKey Id { get; protected set; }

        /*
        object IEntity.Id
        {
            get { return this.Id; }
            set { this.Id = (TKey)Convert.ChangeType(value, typeof(TKey)); }
        }
        */

        private Nullable<DateTime> createdAt = null;
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt
        {
            get { return createdAt ?? DateTime.UtcNow; }
            set { createdAt = value; }
        }

        public virtual TKey CreatedById { get; set; }
        /*
        object IEntity.CreatedById
        {
            get { return this.CreatedById; }
            set { this.CreatedById = (TKey)Convert.ChangeType(value, typeof(TKey)); }
        }
        */

        [DataType(DataType.DateTime)]
        public DateTime? LastModifiedAt { get; set; }
        
        public virtual TKey? LastModifiedById { get; set; }
        /*
        object IEntity.LastModifiedById
        {
            get { return this.LastModifiedById; }
            set { this.LastModifiedById = (TKey)Convert.ChangeType(value, typeof(TKey)); }
        }
        */

        public EntityState State { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }

        int? _requestedHashCode;
        public bool IsTransient()
        {
            return Id.Equals(default(TKey));
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is BaseEntity<TKey>))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (GetType() != obj.GetType())
                return false;

            var item = (BaseEntity<TKey>)obj;

            if (item.IsTransient() || IsTransient())
                return false;
            else
                return item == this;
        }
        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                    _requestedHashCode = Id.GetHashCode() ^ 31; // XOR for random distribution (http://blogs.msdn.com/b/ericlippert/archive/2011/02/28/guidelines-and-rules-for-gethashcode.aspx)

                return _requestedHashCode.Value;
            }
            else
                return base.GetHashCode();
        }
        public static bool operator ==(BaseEntity<TKey> left, BaseEntity<TKey> right)
        {
            if (Equals(left, null))
                return Equals(right, null) ? true : false;
            else
                return left.Equals(right);
        }
        public static bool operator !=(BaseEntity<TKey> left, BaseEntity<TKey> right)
        {
            return !(left == right);
        }
    }
}
