using Gifter.Models;

namespace Gifter.Repositories
{
    public interface IPostRepository
    {
        public List<Post> GetAll();
        public Post GetById(int id);
        public void Add(Post post);
        public void Update(Post post);
        public void Delete(int id);
        public List<Post> GetAllWithComments();
        public Post GetPostByIdWithComments(int id);
    }
}
