public void encrypt(string plainText,out string cypherText) 
{           
    cypherText = ""; //if this parameter return empty string, therefore, something went wrong within the method
    try
    {
        using (SHA256 hash256SHA = SHA256.Create())
        {
            byte[] cypherBytes = hash256SHA.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder cypher = new StringBuilder();

            for (int i = 0; i < cypherBytes.Length; ++i)
            {
                cypher.Append(cypherBytes[i].ToString("x2"));
            }
            cypherText = cypher.ToString();
        }
    }catch (Exception ex)
    {
        //ex.Message.ToString(); //output exception using MessageBox or Console
    }
}
