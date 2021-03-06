﻿using System;

namespace Informedica.GenImport.GStandard.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class FileLinePositionAttribute : Attribute
    {
        public int StartPosition { get; set; }
        public int EndPosition { get; set; }

        public FileLinePositionAttribute(int startPosition, int endPosition)
        {
            if(startPosition > endPosition) throw new ArgumentOutOfRangeException("startPosition", "StartPosition should not be larger than EndPosition");
            
            StartPosition = startPosition;
            EndPosition = endPosition;
        }
    }
}