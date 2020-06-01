import React from 'react';
import { Image, Table } from 'semantic-ui-react';
import styles from './AuthorList.module.scss';

export interface IAuthorListItem {
  id: number;
  name: string;
  imageUrl?: string;
  bookCount: number;
}

export interface IAuthorListProps {
  data: IAuthorListItem[];
  onAuthorClicked(author: IAuthorListItem): void;
}

export const AuthorList: React.FC<IAuthorListProps> = ({
  data,
  onAuthorClicked,
}) => {
  const renderItem = (item: IAuthorListItem, index: number) => {
    const handleItemClicked = () => onAuthorClicked(item);

    return (
      <Table.Row key={index} className={styles.row} onClick={handleItemClicked}>
        <Table.Cell collapsing={true}>
          <Image
            className={styles.authorImage}
            src={item.imageUrl}
            rounded={true}
          />
        </Table.Cell>
        <Table.Cell>{item.name}</Table.Cell>
        <Table.Cell collapsing={true} width="2" textAlign="center">
          {item.bookCount}
        </Table.Cell>
      </Table.Row>
    );
  };

  return (
    <Table selectable={true} striped={true}>
      <Table.Header>
        <Table.HeaderCell />
        <Table.HeaderCell>Name</Table.HeaderCell>
        <Table.HeaderCell>Number of Books</Table.HeaderCell>
      </Table.Header>
      <Table.Body>{data.map(renderItem)}</Table.Body>
    </Table>
  );
};
