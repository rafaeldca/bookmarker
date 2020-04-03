using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bookmarker.Data;

namespace Bookmarker.Services
{
    public class BookmarkService : IBookmarkService
    {
        public BookmarkService()
        {
        }

        public Task AddAsync(Uri url)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(int bookmarkId)
        {
            throw new NotImplementedException();
        }

        public Task<Bookmark> GetAsync(string siteName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bookmark>> GetListAsync(int indexStart, int offset)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int bookmarkId)
        {
            throw new NotImplementedException();
        }
    }
}
