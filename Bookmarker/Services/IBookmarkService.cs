using System.Collections.Generic;
using System.Threading.Tasks;
using Bookmarker.Data;
using System;

namespace Bookmarker.Services
{
    public interface IBookmarkService
    {
        public Task AddAsync(Uri url);

        public Task<Bookmark> GetAsync(string siteName);

        public Task<IEnumerable<Bookmark>> GetListAsync(int indexStart, int offset);

        public Task EditAsync(int bookmarkId);

        public Task RemoveAsync(int bookmarkId);

    }
}
