using Newtonsoft.Json;
using UnityEngine;

public class TestClass
{
    public static void PrintLog() {
        
        Debug.LogError("print log");
    }

    public class TestNewClass
    {
        [JsonProperty("abc")] 
        public int a;
    }
}