using System;
using System.Diagnostics.CodeAnalysis;

namespace Non_Generic_List
{
    public class Part : IEquatable<Part> 
    {
        public string PartName { get; set; }
        public int PartId { get; set; }
        public override string ToString()
        {
            return $"ID : {PartId} Name : {PartName}";
        }
        public override bool Equals(object obj)
        {
            if(obj is null)
            {
                return false;
            }
            Part objAsPart = obj as Part;
            if(objAsPart is null)
            {
                return false;
            }
            else
            {
                return Equals(objAsPart);
            }
        }
        public override int GetHashCode()
        {
            return PartId;
        }
        public bool Equals([AllowNull] Part other)
        {
            if(other is null)
            {
                return false;
            }
            return (this.PartId.Equals(other.PartId));
        }
    }
}
