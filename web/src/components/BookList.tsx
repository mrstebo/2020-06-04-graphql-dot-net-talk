import React from 'react';
import { Card, Image } from 'semantic-ui-react';

export interface IBookListItem {
  id: number;
  name: string;
  imageUrl: string;
  author?: {
    name: string;
  };
}

export interface IBookListProps {
  data: IBookListItem[];
  onBookClicked(book: { id: number }): void;
}

export const BookList: React.FC<IBookListProps> = ({ data, onBookClicked }) => {
  const renderItem = (item: IBookListItem, index: number) => {
    const handleItemClicked = () => onBookClicked(item);

    return (
      <Card key={`book_${index}`} onClick={handleItemClicked}>
        <Image src={item.imageUrl} />
        <Card.Content>
          <Card.Header>{item.name}</Card.Header>
          {item.author && <Card.Meta>{item.author.name}</Card.Meta>}
        </Card.Content>
      </Card>
    );
  };

  return (
    <Card.Group stackable={true} itemsPerRow={4}>
      {data.map(renderItem)}
    </Card.Group>
  );
};
