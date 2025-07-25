﻿namespace XRS_API.Models.ViewModels
{
    public class PaginationMetaData
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; }
        public PaginationMetaData(int totalItemCount, int pageSize, int currentPage)
        {
            TotalItemCount = totalItemCount;
            PageSize = pageSize;
            CurrentPage = currentPage;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)pageSize);
        }
    }
}
