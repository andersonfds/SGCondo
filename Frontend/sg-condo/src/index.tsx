import { createBrowserHistory } from 'history';
import ReactDOM from 'react-dom';
import { Route, Router, Switch } from 'react-router';
import LoginPage from './common/routes/LoginPage/LoginPage';
import './custom.scss';
import reportWebVitals from './reportWebVitals';
import * as dotenv from 'dotenv';
import HomePage from './common/routes/HomePage/HomePage';

dotenv.config();

ReactDOM.render(
  (
    <Router history={createBrowserHistory()}>
      <Switch>
        <Route exact path="/"><LoginPage /></Route>
        <Route path="/home"><HomePage /></Route>
      </Switch>
    </Router>
  ),
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
