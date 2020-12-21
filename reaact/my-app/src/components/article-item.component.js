import React,{useState} from 'react';
import { ArticlesService } from '../services/articles-service';

export const ArticleListItemComponent = (article ) => {
 
 
    const [ counter, setCounter ] = useState( article.likes ); // []
    

    // handleAdd
    const handleAdd = () => {
        let  _service=new ArticlesService(false);
        setCounter( counter + 1);
        _service.updateRemoteCounter(article.id);
      
    }


    return (
        <div >
            <p> { article.content } </p>
            <p>Likes: { counter } </p>
            <button onClick={ handleAdd }>Likes+1</button>
         </div>
    )
}
