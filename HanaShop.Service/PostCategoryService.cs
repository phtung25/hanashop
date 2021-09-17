using HanaShop.Data.Infrastructure;
using HanaShop.Data.Repositories;
using HanaShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanaShop.Service
{
    public interface IPostCategoryService
    {
        void Add(PostCategorie postCategory);

        void Update(PostCategorie postCategory);

        void Delete(int id);

        IEnumerable<PostCategorie> GetAll();

        IEnumerable<PostCategorie> GetAllByParentId(int parentId);

        PostCategorie GetById(int id);
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(PostCategorie postCategory)
        {
            _postCategoryRepository.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategorie> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategorie> GetAllByParentId(int parentId)
        {
            return _postCategoryRepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public PostCategorie GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public void Update(PostCategorie postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }
    }
}
