﻿using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        public PositionType(string value) : base(value)
        {
        }

        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public PositionType()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        //public PositionType(string value) : this()
        //{
        //    Value = value;
        //}

        //public override bool Equals(object obj)
        //{
        //    return obj is PositionType positionType &&
        //           Id == positionType.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}
    }
}
