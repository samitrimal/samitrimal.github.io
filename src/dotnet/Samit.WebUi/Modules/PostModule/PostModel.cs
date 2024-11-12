namespace Samit.WebUi.Modules.PostModule;

public class PostListModel
{
	public required string Url {get;set;}
	public required string Title {get;set;}
}
public class PostDetailModel
{
	public required string Title {get;set;}
	public required string Content{get;set;}
	public required string CreatedDate {get;set;}
	public required string Url {get;set;} 
}

