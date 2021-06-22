﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace GrillBot.App.Extensions
{
    static public class EnumExtensions
    {
        public static string GetDescription(this Enum @enum) => GetAttribute<DescriptionAttribute>(@enum)?.Description;
        static public string GetDisplayName(this Enum @enum) => GetAttribute<DisplayAttribute>(@enum)?.Name;

        static public TAttribute GetAttribute<TAttribute>(this Enum @enum) where TAttribute : Attribute
        {
            var member = @enum.GetType().GetMember(@enum.ToString());
            return member[0].GetCustomAttribute<TAttribute>(false);
        }
    }
}