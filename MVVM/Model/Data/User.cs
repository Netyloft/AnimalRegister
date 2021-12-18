using System;

namespace AnimalRegister.MVVM.Model
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
        public virtual UserRights RightsId { get; set; }
        public virtual Organization OrganizationId { get; set; }
        public virtual Municipalities MunicipalityId { get; set; }
    }
}