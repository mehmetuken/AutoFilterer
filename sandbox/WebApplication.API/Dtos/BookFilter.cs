﻿using AutoFilterer.Attributes;
using AutoFilterer.Enums;
using AutoFilterer.Types;
using System;
using WebApplication.API.Models;

namespace WebApplication.API.Dtos
{
    //[PossibleSortings(nameof(Title), nameof(TotalPage), nameof(Year))]
    public class BookFilter : PaginationFilterBase
    {
        /// <summary>
        /// Search in **Title**, **Author** and **Country**.
        /// </summary>
        [CompareTo(nameof(Book.Title), nameof(Book.Author), nameof(Book.Country))]
        [StringFilterOptions(StringFilterOption.Contains, StringComparison.InvariantCultureIgnoreCase)]
        public string Search { get; set; }

        [StringFilterOptions(StringFilterOption.Contains)]
        public string Title { get; set; }

        public string Language { get; set; }

        public string Author { get; set; }

        public Range<int> TotalPage { get; set; }

        public Range<int> Year { get; set; }
    }
}
