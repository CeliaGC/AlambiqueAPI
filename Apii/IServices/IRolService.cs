using Entities.Entities;

namespace API.IServices
{
    public interface IRolService
    {
        int InsertUserRol(UserRol userRol);
        void DeleteRol(int Id);
        void UpdateRol(UserRol userRol);

        List<UserRol> GetRolByCriteria(int IdRol);
        List<UserRol> GetAll();
    }
}
