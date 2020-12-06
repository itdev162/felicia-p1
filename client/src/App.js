import React, {Component} from 'react';
import axios from 'axios';
import logo from './logo.svg';
import './App.css';
import Entry from './Components/entry';

class App extends Component {
  state = {
    posts:[]
  }

  componentDidMount() {
    axios.get('https://jsonplaceholder.typicode.com/posts').then(res => {
      this.setState({posts: res.data})
    })
  }

  render(){
    return (
      <div className="App">
        <header className="App-header">
          RestaurantBox
        </header>
        {this.state.posts.map(post => {
          return <Entry title={post.title} body={post.body}/>
        })}
        </div>
    );
  }
}

export default App;
