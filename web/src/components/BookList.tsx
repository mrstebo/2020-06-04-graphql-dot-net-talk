import React from 'react';
import { Card, Image } from 'semantic-ui-react';

export interface IBookListItem {
  id: number;
  name: string;
  imageUrl: string;
  author: {
    name: string;
  };
}

export const BookList: React.FC<IBookListProps> = ({ data }) => {
  return (
    <Card.Group stackable={true} itemsPerRow={4}>
      {data.map((item, index) => (
        <Card key={index}>
          <Image src={item.imageUrl} />
          <Card.Content>
            <Card.Header>{item.name}</Card.Header>
            <Card.Meta>{item.author.name}</Card.Meta>
          </Card.Content>
        </Card>
      ))}
    </Card.Group>
  );
};
