namespace ASU.DTO
{
    public class BaseDTO
    {
        public decimal Id { get; set; }
        public bool IsSaved { get; set; }

        public BaseDTO()
        {
        }

        //public virtual bool Equals(BaseDTO obj)
        //{
        //    if (object.ReferenceEquals(null, obj))
        //    {
        //        return false;
        //    }
        //    if (obj.Id != this.Id)
        //    {
        //        return false;
        //    }
        //    if (this.Id != new decimal(0))
        //    {
        //        return true;
        //    }
        //    return object.ReferenceEquals(this, obj);
        //}

        //public override bool Equals(object obj)
        //{
        //    if (object.ReferenceEquals(null, obj))
        //    {
        //        return false;
        //    }
        //    if (object.ReferenceEquals(this, obj))
        //    {
        //        return true;
        //    }
        //    return this.Equals(obj as BaseDTO);
        //}

        //public override int GetHashCode()
        //{
        //    return this.Id.GetHashCode();
        //}

        //public static bool operator ==(BaseDTO left, BaseDTO right)
        //{
        //    return object.Equals(left, right);
        //}

        //public static bool operator !=(BaseDTO left, BaseDTO right)
        //{
        //    return !object.Equals(left, right);
        //}
    }
}
