import React, {useState, useEffect} from 'react';
import { ArticlesService } from '../services/articles-service';
import { ArticleListItemComponent } from './article-item.component';

export const ArticleListComponent = () => {
    
    const [data,setState ]  = useState([]);

    useEffect( () => {
        let  _service=new ArticlesService(false);
        _service.loadArticles ()
            .then( articles => 
                {
                  
                    setState( articles);
                }
               
           );

    }, [])

    
  
    return (
        <>
            <h3 > Articles </h3>

          

            <div className="card-grid">
                
                {
                    data.map( item => (
                        <ArticleListItemComponent 
                            key={ item.id }
                            { ...item }
                        />
                    ))
                }
            
            </div>
        </>
    )
}
