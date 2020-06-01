import gql from 'graphql-tag';

export const GET_AUTHORS = gql`
  query {
    authors {
      id
      name
      imageUrl
      bookCount
    }
  }
`;

export const GET_AUTHOR = gql`
  query($authorId: ID!) {
    author(id: $authorId) {
      name
      imageUrl
      books {
        id
        name
        imageUrl
      }
    }
  }
`;

export const GET_BOOKS = gql`
  query {
    books {
      id
      name
      imageUrl

      author {
        name
      }
    }
  }
`;

export const GET_BOOK = gql`
  query($bookId: ID!, $first: Int) {
    book(id: $bookId) {
      name
      imageUrl
      description
      author {
        name
      }
      reviews(first: $first) {
        id
        name
        title
        content
        createdAt
      }
    }
  }
`;
