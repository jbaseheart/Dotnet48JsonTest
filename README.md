# Dotnet48JsonTest
Project to demonstrate how default Json input deserialization is handled in .Net 4.8

Launch the WebAPI project and then issue a POST request to `http://localhost:54125/api/Test/Post` with the following Json payload:
```
{
  "name": "string",
  "gender": "Male",
  "age": null
}
```
