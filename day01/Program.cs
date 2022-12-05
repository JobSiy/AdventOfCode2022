// See https://aka.ms/new-console-template for more information

using(StreamReader file = new StreamReader("Sample.txt")){

 string? ln;  
  int calCount = 0;
List<int> calList = new List<int>();
 int largestNumber = 0;
 int numSum = 0;
 
 while ((ln = file.ReadLine()) != null) {  
    if(ln.Length == 0){
          calList.Add(calCount);
         if(calCount > largestNumber){
           largestNumber = calCount;
         }
          calCount = 0;
   } else {
      calCount += int.Parse(ln);
   }
 }  
 calList.Sort();
 for(int i = calList.Count() - 3; i <  calList.Count(); i++){
    Console.WriteLine(calList[i]);
    numSum += calList[i];
 }
 Console.WriteLine(numSum);
 file.Close();  
 //hi
} 
