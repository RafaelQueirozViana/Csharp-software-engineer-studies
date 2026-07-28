namespace Lists {
    internal class Program {
        static void Main(string[] args) {

            List<String> usersList = new List<string>();


            usersList.Add("joão");
            usersList.Add("nicolas");
            usersList.Add("pedro");


            int pos = usersList.FindIndex(user => user[0] == 'j');

            List<string> filteredUsers = usersList.FindAll(user => user.Length >= 5);


            usersList.RemoveAt(1);


            foreach (string user in usersList) {
                Console.WriteLine($"pos {usersList.FindIndex(u => u == user)} - {user}");
            }

        }


    }
}
