namespace HomeTask
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string txt1 = "nijat";
			string txt2 = "ali";
			bool result = EqualString(txt1, txt2);
			if(result)
			{
                Console.WriteLine("Adiniz sistemde var");
            }
            else
            {
				Console.WriteLine("Qeydiyyatdan kecdiniz");
            }
        }
		public static bool EqualString(string s1, string s2)
		{
			s1 = s1.ToLower().Trim();
			s2 = s2.ToLower().Trim();
			if(s1.Length != s2.Length) 
			{
				return false;
            }
			for(int i = 0; i < s1.Length; i++)
			{
				if (s1[i] != s2[i])
				{
					return false;
				}
			}
            return true;
        }
	}
}
