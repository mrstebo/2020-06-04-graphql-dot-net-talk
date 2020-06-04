import React from 'react';
import { Redirect, Route, Switch } from 'react-router-dom';
import styles from './App.module.scss';
import { Footer, Header } from './components';
import {
  AuthorCollectionPage,
  AuthorDetailsPage,
  BookCollectionPage,
  BookDetailsPage,
  WelcomePage,
} from './pages';

const App: React.FC = () => {
  return (
    <div className={styles.container}>
      <div>
        <Header className={styles.header} />
        <Switch>
          <Route exact={true} path="/" component={WelcomePage} />
          <Route
            exact={true}
            path="/authors"
            component={AuthorCollectionPage}
          />
          <Route
            exact={true}
            path="/authors/:authorId"
            component={AuthorDetailsPage}
          />
          <Route exact={true} path="/books" component={BookCollectionPage} />
          <Route
            exact={true}
            path="/books/:bookId"
            component={BookDetailsPage}
          />
          <Redirect to="/" />
        </Switch>
      </div>
      <Footer className={styles.footer} />
    </div>
  );
};

export default App;
