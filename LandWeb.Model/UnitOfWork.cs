using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandWeb.Model
{
    public class UnitOfWork : IDisposable
    {
        private ChodaeEntities context = new ChodaeEntities();
        private GenericRepository<member> memberRepository;
        private GenericRepository<users_master> userRepository;

        public GenericRepository<member> MemberRepository
        {
            get
            {
                if (this.memberRepository == null)
                {
                    this.memberRepository = new GenericRepository<member>(context);
                }


                return memberRepository;
            }
        }

        public GenericRepository<users_master> UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<users_master>(context);
                }
                return userRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
