import  articlesData  from "./local-data";

export class ArticlesService{
  

    constructor(useWeb=false) { 
        this.pullFromWeb=useWeb; 
        this.url=`https://myurl/v1/articles`;
    }

     loadArticles=async( ) =>{
      
        if(this.pullFromWeb){
            //I left the error handling pending
            const resp = await fetch(  this.url );
            const data  = await resp.json();
        
            const articles = data.map( art => {
                return {
                    id: art.id,
                    content: art.content,
                    likes:art.likes
                }
            });
            return articles;
        }
        return new Promise((resolve, reject) => {
           
            setTimeout( function() {
              resolve(articlesData) ;
            }, 100) 
          }) 
        ;
     }

     updateRemoteCounter=async(articleId)=>{
       console.log("Calling api for incrementing counter");
          //I left the error handling pending
         //here goes a call to a put web method
       /*  const response = await fetch(`${this.url}/${articleId}/incrementcounter` , { 
            method: 'PUT', 
            headers: { 
              'Content-type': 'application/json'
            },
            
          }); 
          const resData = await response.json(); 
         if( response.ok)
              return  resData
          return -1 ; */
          return 10; //here it should return the remote likes counter
     }

    


}
