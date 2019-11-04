using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// The connection between database and service level for member objects.
    /// </summary>
    class MemberRepository : IRepository<Member, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor for member repository.
        /// </summary>
        /// <param name="c">Used to connect repository with database.</param>
        public MemberRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Returns all members from database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Member> All()
        {
            return context.Members;
        }

        /// <summary>
        /// Adds object to the database.
        /// </summary>
        /// <param name="member">Object being added.</param>
        public void Add(Member member)
        {
            context.Members.Add(member);
        }

        /// <summary>
        /// Removes object from database.
        /// </summary>
        /// <param name="member">Object being removed.</param>
        public void Remove(Member member)
        {
            context.Members.Remove(member);
        }

        /// <summary>
        /// Finds a specific member in database on id.
        /// </summary>
        /// <param name="id">The id used to find object.</param>
        /// <returns></returns>
        public Member Find(int id)
        {
            Member member = context.Members.Find(id); //(m => m.MemberId == id);
            return member;
        }

        /// <summary>
        /// Saves changes to the database.
        /// </summary>
        /// <param name="member">Object being changed.</param>
        public void Edit(Member member)
        {
            context.SaveChanges();
        }
    }
}
