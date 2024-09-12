using TestPackage;
using TestPackage2;

namespace TestPackageUser
{
	public class UserClass
	{
		public void UserMethod()
		{
			PackageClass.PackageMethod();
			PackageClass2.PackageMethod2();
		}
	}
}