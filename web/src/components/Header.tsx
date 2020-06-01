import React from 'react';
import { useHistory, useLocation } from 'react-router-dom';
import { Menu } from 'semantic-ui-react';

export interface IHeaderProps {
  className?: string;
}

export const Header: React.FC<IHeaderProps> = ({ className }) => {
  const history = useHistory();
  const location = useLocation();

  const handleBooksClicked = () => history.push('/books');
  const handleAuthorsClicked = () => history.push('/authors');

  return (
    <Menu className={className} inverted={true} attached={true} size="massive">
      <Menu.Item header={true}>Buzzword Library</Menu.Item>
      <Menu.Item
        onClick={handleBooksClicked}
        active={location.pathname.startsWith('/books')}
      >
        Books
      </Menu.Item>
      <Menu.Item
        onClick={handleAuthorsClicked}
        active={location.pathname.startsWith('/authors')}
      >
        Authors
      </Menu.Item>
    </Menu>
  );
};
