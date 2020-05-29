import cx from 'classnames';
import React from 'react';
import styles from './Footer.module.scss';

export interface IFooterProps {
  className?: string;
}

export const Footer: React.FC<IFooterProps> = ({ className }) => {
  return (
    <footer className={cx(styles.container, className)}>
      Created by{' '}
      <a className={styles.link} href="https://github.com/mrstebo">
        mrstebo
      </a>{' '}
      for{' '}
      <a
        className={styles.link}
        href="https://www.meetup.com/Behind-The-Buzz-Word/"
      >
        Behind The Buzzword
      </a>
    </footer>
  );
};
