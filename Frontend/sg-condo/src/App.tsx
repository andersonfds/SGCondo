import { createBrowserHistory } from 'history';
import React from 'react';
import { Provider } from 'react-redux';
import { Route, Router, Switch } from 'react-router';
import './App.css';
import HomePage from './common/routes/HomePage/HomePage';
import LoginPage from './common/routes/LoginPage/LoginPage';
import store from './store';

function App() {
  return (
    <Provider store={store}>
      <Router history={createBrowserHistory()}>
        <Switch>
          <Route exact path="/"><LoginPage /></Route>
          <Route path="/home"><HomePage /></Route>
        </Switch>
      </Router>
    </Provider>
  );
}

export default App;
