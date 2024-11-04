using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Membership.Data;
using Library_Membership.Entities;

namespace Library_Membership.Repositories
{
    internal class MemberRepository
    {
        // Method to retrieve all members

        public GenericResponse<List<Member>> GetAllMembers()
        {
            var members = DataStore.Members;

            return new GenericResponse<List<Member>>
            {
                Success = true,
                Data = members
            };
        }

        // Method to retrieve a member by their name

        public GenericResponse<Member> GetByName(string name)
        {
            var member = DataStore.Members.FirstOrDefault(x => x.Name == name);

            if (member == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found"
                };
            }

            return new GenericResponse<Member>
            {
                Success = true,
                Data = member
            };
        }

        // Method to retrieve a member by their email

        public GenericResponse<Member> GetByEmail(string email)
        {
            var member = DataStore.Members.FirstOrDefault(x => x.Email == email);

            if (member == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found"
                };
            }

            return new GenericResponse<Member>
            {
                Success = true,
                Data = member
            };
        }
    }
}
