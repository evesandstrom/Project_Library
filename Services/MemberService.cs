using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    /// <summary>
    /// Executes queries requested by the GUI for the member objects.
    /// </summary>
    class MemberService : IService
    {
        MemberRepository memberRepository;

        /// <summary>
        /// Lets the GUI know a change was made and that it should be updated.
        /// </summary>
        public event EventHandler Updated;

        /// <summary>
        /// Constructor for memberservice, creates a repository for the service.
        /// </summary>
        /// <param name="rFactory">A repository factory, so the service can create its own repository</param>
        public MemberService(RepositoryFactory rFactory)
        {
            this.memberRepository = rFactory.CreateMemberRepository();
        }

        /// <summary>
        /// Returns all members.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Member> All()
        {
            return memberRepository.All();
        }

        /// <summary>
        /// Adds a member to the database.
        /// </summary>
        /// <param name="a">Member object to be added.</param>
        public void Add(Member a)
        {
            memberRepository.Add(a);
        }

        /// <summary>
        /// Finds the last member in the database and returns the id.
        /// </summary>
        /// <returns></returns>
        public int findLastId()
        {
            Member member = memberRepository.All().Last();
            return member.MemberId;
        }

        /// <summary>
        /// If there are no previous members the id is set to 1, else it adds the last id number with 1.
        /// </summary>
        /// <returns></returns>
        public int GenerateId()
        {
            if (memberRepository.All().Count() == 0)
            {
                return 1;
            }
            else
            {
                int id = findLastId();
                return id++;
            }
        }

        /// <summary>
        /// The Edit method makes sure that the given member object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="a">Member to be saved.</param>
        public void Edit(Member a)
        {
            memberRepository.Edit(a);
            OnUpdated(new EventArgs());
        }

        /// <summary>
        /// Raises the event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnUpdated(EventArgs e)
        {
            Updated?.Invoke(this, e);
        }
    }
}
