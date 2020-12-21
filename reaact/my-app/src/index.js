import React from 'react';
import ReactDOM from 'react-dom';
import {ArticleListComponent} from './components/articles.component';
import './index.css';


const divRoot = document.querySelector('#app');
ReactDOM.render( <ArticleListComponent />  , divRoot );

