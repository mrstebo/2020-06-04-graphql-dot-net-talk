import React from 'react';
import { Divider, Header, Image, Segment } from 'semantic-ui-react';
import logo from '../assets/behind-the-buzzword-logo.jpeg';
import styles from './WelcomePage.module.scss';

export const WelcomePage: React.FC = () => {
  return (
    <div className={styles.container}>
      <Header size="huge">
        Buzzword Library
        <Header.Subheader>Recommended Reading</Header.Subheader>
      </Header>
      <Image className={styles.logo} src={logo} />
      <Divider />
      <Segment circular={true} padded={true} size="massive">
        Source code available{' '}
        <a
          href="https://github.com/mrstebo/2020-06-04-graphql-dot-net-talk"
          target="_blank"
        >
          here
        </a>
      </Segment>
    </div>
  );
};
