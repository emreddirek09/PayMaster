using PayMasterProject.BusinessLayer.Abstract;
using PayMasterProject.DataAccessLayer.Abstract;
using PayMasterProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMasterProject.BusinessLayer.Concrete
{
    public class BlockManager:IBlockService
    {
        private readonly IBlockDal _blockDal;
        public BlockManager(IBlockDal blockDal)
        {
            _blockDal = blockDal;
        }

        public void TDelete(Block t)
        {
            _blockDal.Delete(t);
        }

        public List<Block> TGetAll()
        {
            return _blockDal.GetAll();

        }

        public Block TGetById(int id)
        {
            return _blockDal.GetById(id);
        }

        public void TInsert(Block t)
        {
            _blockDal.Insert(t);
        }

        public void TUpdate(Block t)
        {
            _blockDal.Update(t);
        }
    }
}
