import React from 'react';
import { Image, Table } from 'semantic-ui-react';
import styles from './AuthorList.module.scss';

export interface IAuthorListProps {
  data: Array<{
    id: number;
    name: string;
    imageUrl?: string;
    bookCount: number;
  }>;
}

export const AuthorList: React.FC<IAuthorListProps> = ({ data }) => {
  return (
    <Table>
      <Table.Header>
        <Table.HeaderCell />
        <Table.HeaderCell>Name</Table.HeaderCell>
        <Table.HeaderCell>Number of Books</Table.HeaderCell>
      </Table.Header>
      <Table.Body>
        {data.map((item, index) => (
          <Table.Row key={index}>
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
        ))}
      </Table.Body>
    </Table>
  );
};
