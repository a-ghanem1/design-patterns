namespace DesignPatterns.SolidPrinciples;

public interface IUserManagement
{
  void UpdateUserProfile(Customer customer);
  void ChangePassword(Customer customer, String newPassword);
}
