import React, { useState } from 'react';
import { Form, FormTextAreaProps } from 'semantic-ui-react';

export interface IBookReviewFormData {
  name: string;
  title: string;
  review: string;
}

export interface IBookReviewFormProps {
  onSubmit(data: IBookReviewFormData): void;
}

export const BookReviewForm: React.FC<IBookReviewFormProps> = ({
  onSubmit,
}) => {
  const [state, setState] = useState<IBookReviewFormData>({
    name: '',
    title: '',
    review: '',
  });

  const handleInputChange = (e: React.ChangeEvent<HTMLInputElement>) =>
    setState({ ...state, [e.target.name]: e.target.value });

  const handleTextAreaChange = (
    e: React.FormEvent<HTMLTextAreaElement>,
    data: FormTextAreaProps
  ) => setState({ ...state, [e.currentTarget.name]: data.value });

  const handleSubmit = () => {
    onSubmit(state);
    setState({
      name: '',
      title: '',
      review: '',
    });
  };

  return (
    <Form onSubmit={handleSubmit}>
      <Form.Input
        required={true}
        label="Your Name"
        name="name"
        value={state.name}
        onChange={handleInputChange}
      />
      <Form.Input
        required={true}
        label="Title"
        name="title"
        value={state.title}
        onChange={handleInputChange}
      />
      <Form.TextArea
        required={true}
        rows={8}
        label="Review"
        name="review"
        value={state.review}
        onChange={handleTextAreaChange}
      />
      <Form.Button type="submit" primary={true}>
        Submit Review
      </Form.Button>
    </Form>
  );
};
